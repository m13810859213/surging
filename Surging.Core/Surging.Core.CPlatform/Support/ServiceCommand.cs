﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Surging.Core.CPlatform.Support
{
   public class ServiceCommand
    {
        public int FailoverCluster { get; set; } = 3;
        public bool CircuitBreakerForceOpen { get; set; }
        /// <summary>
        /// 容错策略
        /// </summary>
        public StrategyType Strategy { get; set; }
        /// <summary>
        /// 执行超时时间
        /// </summary>
        public int ExecutionTimeoutInMilliseconds { get; set; } = 1000;
        /// <summary>
        /// 是否开启缓存
        /// </summary>
        public bool RequestCacheEnabled { get; set; }
        /// <summary>
        /// 注入
        /// </summary>
        public string Injection { get; set; } = "return null";

        public string[] InjectionNamespaces { get; set; }

        /// <summary>
        /// 错误率达到多少开启熔断保护
        /// </summary>
        public int BreakeErrorThresholdPercentage { get; set; } = 50;
        /// <summary>
        /// 熔断多少毫秒后去尝试请求
        /// </summary>
        public int BreakeSleepWindowInMilliseconds { get; set; } = 60000;
        /// <summary>
        ///  	是否强制关闭熔断
        /// </summary>
        public bool BreakerForceClosed { get; set; }

        /// <summary>
        ///    10秒钟内至少多少请求失败，熔断器才发挥起作用
        /// </summary>
        public int BreakerRequestVolumeThreshold { get; set; } = 20;

        /// <summary>
        /// 信号量最大并发度
        /// </summary>
        public int MaxConcurrentRequests { get; set; } = 10;

    }
}
