/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using System;
using Easy.ViewPort.Validator;

namespace Easy.ViewPort.Descriptor
{
    public class FileDescriptor : BaseDescriptor<FileDescriptor>
    {
        public FileDescriptor(Type modelType, string property)
            : base(modelType, property)
        {
            this.TagType = HTMLEnumerate.HTMLTagTypes.File;
            this.TemplateName = "FileInput";
        }
        
    }
}
