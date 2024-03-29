﻿using System;

[Serializable]
public class Description
{
    public bool invert_sort_order;
    public ScoreFormat score_format;
}

[Serializable]
public class Title
{
    public string ru;
    public string en;
}

[Serializable]
public class ScoreFormat
{
    public string type;
    public Options options;
}

[Serializable]
public class Options
{
    public int decimal_offset;
}

[Serializable]
public class LeaderboardDescription
{
    public int appID;
    public string name;
    public bool @default;
    public Description description;
    public Title title;
}
