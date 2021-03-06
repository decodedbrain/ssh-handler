﻿// Setting
//
// Douglas Thrift
//
// Setting.cs

/*  Copyright 2014 Douglas Thrift
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */

public struct Setting
{
    public string option;
    public string pattern;
    public string name;
    public string usage;
    public SettingType type;
    public bool handler;

    public Setting(string option, string pattern, string name, string usage, SettingType type, bool handler = false)
    {
        this.option = option;
        this.pattern = pattern;
        this.name = name;
        this.usage = usage;
        this.type = type;
        this.handler = handler;
    }
}
