#!/bin/sh

# IN OSX, COMPRESS FILES IN /res FOLDER TO ArchiveResource.cs C# FILE
cd "$(dirname "$0")"
chmod +x packfolder
./packfolder ../res ../Src/ArchiveResource.cs -csharp -x "*IconBundler*;sciter.dll;.DS_store"