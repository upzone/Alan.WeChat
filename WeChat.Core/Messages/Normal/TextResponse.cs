﻿using System.Xml.Serialization;

namespace WeChat.Core.Messages.Normal
{
    /// <summary>
    /// 回复文本消息
    /// </summary>
    [XmlRoot("xml")]
    public class TextResponse : ResponseBase
    {
        /// <summary>
        /// 回复的消息内容（换行：在content中能够换行，微信客户端就支持换行显示）
        /// </summary>
        public string Content { get; set; }

    }
}
