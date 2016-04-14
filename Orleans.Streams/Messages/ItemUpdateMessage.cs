﻿using System;
using System.Collections.Generic;
using Orleans.Streams.Messages;

namespace Orleans.Collections.Messages
{
    /// <summary>
    /// Message containing items that have been recently updated by the sender.
    /// </summary>
    /// <typeparam name="T">Type of items</typeparam>
    [Serializable]
    public class ItemUpdateMessage<T> : ItemMessage<T>
    {
        public ItemUpdateMessage(IEnumerable<T> items) : base(items)
        {
        }
    }
}