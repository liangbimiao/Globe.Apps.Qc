﻿using SuperMap.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globe.QcApp.Common.Core
{
    public class SmObjectLocator
    {
        private static SmObjectLocator smObjectLocator;
        private static SceneControl globeObject = null;

        /// <summary>
        /// 单例模式添加单例实体
        /// </summary>
        /// <returns></returns>
        public static SmObjectLocator getInstance()
        {
            if (smObjectLocator == null)
            {
                smObjectLocator = new SmObjectLocator();
                globeObject = new SceneControl();
            }
            return smObjectLocator;
        }

        //单例模式
        private SmObjectLocator()
        {
            if (smObjectLocator != null)
            {
                throw new Exception("不能通过new关键字实例化对象，请调用静态函数getInstance()获取对象实例！");
            }
        }

        /// <summary>
        /// 三维球体控件对象
        /// </summary>
        public SceneControl GlobeObject { get { return globeObject; } }
    }
}
