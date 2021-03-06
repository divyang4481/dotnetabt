﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abt
{
    public delegate void FileParsed();

    public interface IFileParser
    {
        /// <summary>
        /// path to the parsing file
        /// </summary>
        string FileName { get; set; }

        /// <summary>
        /// result lines of parsing
        /// </summary>
        List<SourceLine> Lines { get; }

        /// <summary>
        /// get new instance of the parser
        /// </summary>
        IFileParser NewInstance { get; }

        /// <summary>
        /// file is parsed successfully
        /// </summary>
        event FileParsed FileParsed;

        /// <summary>
        /// the working directory
        /// </summary>
        string WorkingDir { get; set; }

        /// <summary>
        /// the file extension supported by this parser
        /// </summary>
        string FileExtension { get; }
    }
}
