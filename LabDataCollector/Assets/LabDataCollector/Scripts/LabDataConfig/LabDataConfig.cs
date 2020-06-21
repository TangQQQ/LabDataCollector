﻿namespace LabDataCollector
{
    public class LabDataConfig
    {
        public bool SendToServer { get; set; }
        /// <summary>
        /// 上传服务器的地址
        /// </summary>
        public string ServerPath { get; set; }
        /// <summary>
        /// 存储本地文件名字前的时间格式
        /// </summary>
        public string LocalSaveDataTimeLayout { get; set; }

        public string ProjectId { get; set; }

        public LabDataConfig()
        {
            ServerPath = "http://";
            SendToServer = false;
            LocalSaveDataTimeLayout = "yyyyMMddHH";
            ProjectId = "Null";
        }
    }

}

