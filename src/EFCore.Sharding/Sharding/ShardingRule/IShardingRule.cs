﻿namespace EFCore.Sharding
{
    /// <summary>
    /// 分片规则接口
    /// </summary>
    public interface IShardingRule
    {
        /// <summary>
        /// 找表方法
        /// </summary>
        /// <param name="obj">实体对象</param>
        /// <returns>具体表名</returns>
        string FindTable(object obj);
    }
}
