using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDatasetLibrary.Core.Dtos.Foto;
using UserDatasetLibrary.Core.Extensions;
using UserDatasetLibrary.Core.Services.Interfaces;
using UserDatasetLibrary.DAL;
using UserDatasetLibrary.DAL.Entities;

namespace UserDatasetLibrary.Core.Services
{
    internal class FotoService : IFotoService
    {
        private readonly UserDbContext _context;

        public FotoService(UserDbContext context)
        {
            this._context = context;
        }

        public async Task CreateFoto(FotoDto foto)
        {
            FotoEntity entity = foto.ToEntity();
            await _context.Fotos.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public FotoDto? GetFotoById(int id)
        {
            FotoEntity? entity = _context.Fotos.Where(f => f.Id == id).FirstOrDefault();
            // TODO: throw entity not found exception and set up exception handling middleware
            return entity?.ToDto();
        }
    }
}
