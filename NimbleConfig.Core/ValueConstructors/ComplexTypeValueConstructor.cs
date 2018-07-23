﻿using System;
using Microsoft.Extensions.Configuration;
using NimbleConfig.Core.Configuration;
using NimbleConfig.Core.ConfigurationReaders;
using NimbleConfig.Core.Parsers;

namespace NimbleConfig.Core.ValueConstructors
{
    public class ComplexTypeValueConstructor : IValueConstructor
    {
        public dynamic ConstructValue(IConfiguration configuration,
            Type configType,
            IKeyName keyName,
            IConfigurationReader reader,
            IParser parser)
        {
            var value = reader.Read(configuration, configType, keyName);
            value = parser == null ? value : parser.Parse(configType, value);
            return value;
        }
    }
}