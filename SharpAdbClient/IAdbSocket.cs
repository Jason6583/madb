﻿// <copyright file="IAdbSocket.cs" company="The Android Open Source Project, Ryan Conrad, Quamotion">
// Copyright (c) The Android Open Source Project, Ryan Conrad, Quamotion. All rights reserved.
// </copyright>

namespace SharpAdbClient
{
    using SharpAdbClient.Exceptions;
    using System;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Provides a common interface for any class that acts as a client for the
    /// Android Debug Bridge.
    /// </summary>
    public interface IAdbSocket : IDisposable
    {
        /// <include file='IAdbSocket.xml' path='/IAdbSocket/Connected/*'/>
        bool Connected { get; }

        /// <include file='IAdbSocket.xml' path='/IAdbSocket/SendAdbRequest/*'/>
        void SendAdbRequest(string request);

        /// <include file='IAdbSocket.xml' path='/IAdbSocket/Send_byte_int_int/*'/>
        void Send(byte[] data, int length);

        /// <include file='IAdbSocket.xml' path='/IAdbSocket/SendSyncRequest_SyncCommand_string_int/*'/>
        void SendSyncRequest(SyncCommand command, string path, int permissions);

        /// <include file='IAdbSocket.xml' path='/IAdbSocket/SendSyncRequest/*'/>
        void SendSyncRequest(SyncCommand command, int length);

        /// <include file='IAdbSocket.xml' path='/IAdbSocket/SendSyncRequest_SyncCommand_string/*'/>
        void SendSyncRequest(SyncCommand command, string path);

        /// <include file='IAdbSocket.xml' path='/IAdbSocket/ReadSyncResponse/*'/>
        SyncCommand ReadSyncResponse();

        /// <include file='IAdbSocket.xml' path='/IAdbSocket/ReadAdbResponse/*'/>
        AdbResponse ReadAdbResponse();

        /// <include file='IAdbSocket.xml' path='/IAdbSocket/Read_byte/*'/>
        void Read(byte[] data);

        /// <include file='IAdbSocket.xml' path='/IAdbSocket/ReadString/*'/>
        string ReadString();

        /// <include file='IAdbSocket.xml' path='/IAdbSocket/ReadSyncString/*'/>
        string ReadSyncString();

        /// <include file='IAdbSocket.xml' path='/IAdbSocket/ReadStringAsync/*'/>
        Task<string> ReadStringAsync();

        /// <include file='IAdbSocket.xml' path='/IAdbSocket/Close/*'/>
        void Close();

        /// <include file='IAdbSocket.xml' path='/IAdbSocket/Read_byte_int_int/*'/>
        void Read(byte[] data, int length);

        /// <include file='IAdbSocket.xml' path='/IAdbSocket/GetShellStream/*'/>
        Stream GetShellStream();
    }
}