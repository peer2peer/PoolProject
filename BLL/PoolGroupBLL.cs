﻿/***************************************************************************
 *
 * Copyright (c) 2018 苏州云链信息咨询有限公司 All Rights Reserved.
 * 机器名称：      DESKTOP-DF8B3JQ
 * 公司名称：      苏州云链信息咨询有限公司
 * 命名空间：      Pool.BLL
 * 文件名：        PoolConfigBLL
 * 唯一标识：      01442bc3-6f5a-47fa-85fb-d29c7dc9a45d
 * 当前的用户域：  DESKTOP-DF8B3JQ
 * 创建人：        DevC
 * 创建时间：      2018/3/2 12:59:04
 * 描述：          
 *
 *=====================================================================*/


using System;
using System.Collections.Generic;
using System.Text;
using Pool.Model;

namespace Pool.BLL
{
    public class PoolGroupBLL
    {
        public static int UpdatePoolGroup(PoolGroup group)
        {
            return SugarBase.DBAutoClose.Updateable(group).ExecuteCommand();
        }

        public static PoolGroup GetPoolGroupByID(int id)
        {
            return SugarBase.DBAutoClose.Queryable<PoolGroup>().InSingle(id);
        }

        public static List<PoolGroup> GetAllPoolGroup()
        {
            return SugarBase.DBAutoClose.Queryable<PoolGroup>().ToList();
        }

        public static int DelPoolGroupByID(int id)
        {
            return SugarBase.DBAutoClose.Deleteable<PoolGroup>().In(id).ExecuteCommand();
        }
    }
}
