using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IFileStorageService
{
    Task<string> SaveClientImageAsync(Stream fileStream, string fileName);
}
