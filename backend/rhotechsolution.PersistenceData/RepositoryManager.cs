﻿using rhotechsolution.Application.Contracts;
using rhotechsolution.Application.Contracts.Interfaces;
using rhotechsolution.PersistenceData.ApplicationDbContext;
using rhotechsolution.PersistenceData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhotechsolution.PersistenceData
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IProductRepository> _productRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(repositoryContext));
        }

        public IProductRepository Product => _productRepository.Value;
        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
        
    }
}
