﻿/////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Autodesk, Inc. All rights reserved 
// Written by Philippe Leefsma 2014 - ADN/Developer Technical Services
//
// Permission to use, copy, modify, and distribute this software in
// object code form for any purpose and without fee is hereby granted, 
// provided that the above copyright notice appears in all copies and 
// that both that copyright notice and the limited warranty and
// restricted rights notice below appear in all supporting 
// documentation.
//
// AUTODESK PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS. 
// AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
// MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE.  AUTODESK, INC. 
// DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
// UNINTERRUPTED OR ERROR FREE.
/////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Autodesk.ADN.Toolkit.ViewData.DataContracts
{
    /////////////////////////////////////////////////////////////////////////////////
    // Error returned by View Data Service 
    //
    /////////////////////////////////////////////////////////////////////////////////
    public class ViewDataError
    {
        public HttpStatusCode StatusCode
        {
            get;
            set;
        }

        public string Reason
        {
            get;
            set;
        }

        public string DeveloperMessage
        {
            get;
            set;
        }

        public string ErrorCode
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "more info")]
        public Uri MoreInfo
        {
            get;
            set;
        }

        public Exception Exception
        {
            get;
            set;
        }

        public ViewDataError()
        { 
        
        }

        public ViewDataError(Exception ex)
        {
            Exception = ex;
        }

        public ViewDataError(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }
    }
}
