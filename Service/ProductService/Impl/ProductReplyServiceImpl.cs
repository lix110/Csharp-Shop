﻿using Commons.BaseModels;
using Mapper;
using MVC卓越项目.Commons.Utils;
using Service.ProductService.VO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class ProductReplyServiceImpl : IProductReplyService
    {
        public void addComment(long uid, List<store_product_reply> store_Product_Reply)
        {
            int OID = Convert.ToInt32(store_Product_Reply[0].oid);
            using (var db = new eshoppingEntities())
            {
               var tran =   db.Database.BeginTransaction();
                store_Product_Reply.ForEach(e => {
                e.uid = uid;
                e.create_time = DateTime.Now;
                    e.reply_type = "product";
                e.update_time = DateTime.Now;
                e.is_del = false;
                e.is_reply = false;
            });
              store_order order =  db.store_order.Where(e => e.id == OID).FirstOrDefault();
                order.status = 3;
                
                db.store_product_reply.BulkInsert(store_Product_Reply);
                db.BulkSaveChanges();
                tran.Commit();
            }
        }

        public PageModel GetProdctReplyData(QueryData queryData)
        {
            using (var db = new eshoppingEntities())
            {
           

                return new PageUtils<Object>(queryData.Page, queryData.Limit).StartPage(db.store_product_reply.Where(e => e.is_del == false).Join(db.store_product, e => e.product_id, e => e.id, (reply, product) => new
                {
                    reply = reply,
                    product = product
                }).Join(db.eshop_user, e => e.reply.uid, e => e.uid, (info, user) => new { info = info, user = user }).OrderByDescending(e=>e.info.reply.create_time));
            }
        }

        /// <summary>
        /// 获取商品评论信息
        /// </summary>
        /// <param name="pid">productID</param>
        /// <param name="page">页数</param>
        /// <param name="limit">页面大小</param>
        /// <returns></returns>
        public PageModel GetReplyByPid(long pid, int page, int limit)
        {
            using (var db = new eshoppingEntities())
            {
                return new PageUtils<Object>(page, limit).StartPage(db.store_product_reply.Where(e => e.product_id == pid && e.is_del == false).
                    Join(
                    db.eshop_user,  //外部对象
                    reply => reply.uid,         //内部的key
                user => user.uid,         //外部的key
                (reply, user) => new        //结果
                {
                    pid=reply.product_id,
                    id = reply.id,
                    comment = reply.comment,
                    username = user.username,
                    nickname = user.nickname,
                    createTime  = reply.create_time,
                    isReply = reply.is_reply,
                    oid = reply.oid,
                    unique = reply.unique,
                    productScore = reply.product_score,
                    serviceScore = reply.service_score,
                    avatar = user.avatar,
                    pics = reply.pics
                }).GroupJoin(db.store_order_cart_info,e=>e.unique,e=>e.unique, (a,b)=>new { 
                   commentInfo = a,
                    productInfo = b.FirstOrDefault()
                }).OrderBy(e=>e.commentInfo.id));
            }
        }

        public void RemoveReply(int id)
        {
            using (var db = new eshoppingEntities())
            {
                var result= db.store_product_reply.Find(id);
                result.is_del = true;
                db.SaveChanges();
            }
        }
    }
}
