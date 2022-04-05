﻿namespace Unity.GameBackend.CloudCode.Http
{
    internal interface IError
    {
        string Type { get; }
        string Title { get; }
        int? Status { get; }
        int Code { get; }
        string Detail { get; }
    }
}