using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace semana7
{
    public interface IQRCode
    {
        Task<string> ScanAsync();
    }
}
