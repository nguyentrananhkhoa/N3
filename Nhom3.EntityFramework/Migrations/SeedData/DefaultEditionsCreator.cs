﻿using System.Linq;
using Abp.Application.Editions;
using Nhom3.Editions;
using Nhom3.EntityFramework;

namespace Nhom3.Migrations.SeedData
{
    public class DefaultEditionsCreator
    {
        private readonly Nhom3DbContext _context;

        public DefaultEditionsCreator(Nhom3DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateEditions();
        }

        private void CreateEditions()
        {
            var defaultEdition = _context.Editions.FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
            if (defaultEdition == null)
            {
                defaultEdition = new Edition { Name = EditionManager.DefaultEditionName, DisplayName = EditionManager.DefaultEditionName };
                _context.Editions.Add(defaultEdition);
                _context.SaveChanges();

                //TODO: Add desired features to the standard edition, if wanted!
            }   
        }
    }
}