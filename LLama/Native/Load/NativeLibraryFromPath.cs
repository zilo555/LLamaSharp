﻿using LLama.Abstractions;
using System.Collections.Generic;

namespace LLama.Native
{
    /// <summary>
    /// A native library specified with a lcoal file path.
    /// </summary>
    public class NativeLibraryFromPath: INativeLibrary
    {
        private string _path;

        /// <inheritdoc/>
        public NativeLibraryMetadata? Metadata => null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public NativeLibraryFromPath(string path)
        {
            _path = path;
        }
        
        /// <inheritdoc/>
        public IEnumerable<string> Prepare(SystemInfo systemInfo, bool fromRemote, NativeLogConfig.LLamaLogCallback? logCallback)
        {
            return fromRemote? [] : [_path];
        }
    }
}
