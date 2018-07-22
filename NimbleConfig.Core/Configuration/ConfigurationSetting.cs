﻿using System;

namespace NimbleConfig.Core.Configuration
{
    public abstract class ConfigurationSetting<TValue>
    {
        public virtual TValue Value { get; protected set; }

        /// <summary>
        /// This method gets called when setting the value, use this to customize the logic
        /// </summary>
        /// <param name="rawConfigValue">The raw value read from the configuration</param>
        /// <param name="valueParserFunc">The parser function generated by the library</param>
        public virtual void SetValue(object rawConfigValue, Func<object, object> valueParserFunc)
        {
            Value = (TValue)valueParserFunc(rawConfigValue);
        }
    }

}
