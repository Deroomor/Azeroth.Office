﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel.DbTool
{
    public interface IDbManager
    {
        /// <summary>
        /// 获取数据库类别
        /// </summary>
        DbType GetDbType();

        /// <summary>
        /// 设定数据库连接字符串
        /// </summary>
        /// <param name="cnnstr"></param>
        void SetConnectionString(string cnnstr);

        /// <summary>
        /// 获取数据库下的所有表
        /// </summary>
        /// <param name="cnnstr"></param>
        /// <returns></returns>
        List<string> GetAllTableName();

        /// <summary>
        /// 获取表的元数据
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        TableMeta GetTableMetaByName(string tableName);

        /// <summary>
        /// 获取所有表格的元数据
        /// </summary>
        /// <returns></returns>
        List<TableMeta> GetTableMeta();

        /// <summary>
        /// 添加表格
        /// </summary>
        /// <param name="tablemeta"></param>
        /// <returns></returns>
        bool CreateTable(TableMeta tablemeta);

        /// <summary>
        /// 重命名，表名称，列名称
        /// </summary>
        /// <param name="dictName"></param>
        /// <returns></returns>
        bool AlterTableWithRename(TableMeta tablemeta, Dictionary<string, string> dictName);

        /// <summary>
        /// 修改表设计，新增，修改，删除 列，没有重命名
        /// </summary>
        /// <param name="tablemeta"></param>
        /// <returns></returns>
        bool AlterTable(TableMeta tablemeta);
    }
}