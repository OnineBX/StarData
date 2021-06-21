//  DataResult.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       15:53:27 21/6/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
using System.Collections.Generic;
using StarData.Core.Error;

namespace StarData.Core.Repositories
{
    public class DataResult<E> where E: class
    {
        private IReadOnlyList<DataError> _errors = new List<DataError>();
        public IReadOnlyList<DataError> Errors => _errors;
        public bool Succeeded { get; protected set; }

        private static readonly DataResult<E> _success = new DataResult<E> { Succeeded = true };
        public static DataResult<E> Success => _success;


        public E Data { get; private set; }

        public DataResult()
        {
            
        }
    }
}
