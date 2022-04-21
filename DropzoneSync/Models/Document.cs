using Microsoft.AspNetCore.Http;

namespace DropzoneSync.Models
{
    public class Document
    {
        public IFormFileCollection Documents { get; set; }
    }
}