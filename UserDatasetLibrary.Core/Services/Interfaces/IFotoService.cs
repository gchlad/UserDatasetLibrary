using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDatasetLibrary.Core.Dtos.Foto;

namespace UserDatasetLibrary.Core.Services.Interfaces
{
    public interface IFotoService
    {
        Task CreateFoto(FotoDto foto);
        FotoDto? GetFotoById(int id);
    }
}
