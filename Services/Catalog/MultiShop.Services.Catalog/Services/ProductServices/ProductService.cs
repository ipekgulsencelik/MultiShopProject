using AutoMapper;
using MongoDB.Driver;
using MultiShop.Services.Catalog.DTOs.ProductDTOs;
using MultiShop.Services.Catalog.Entities;
using MultiShop.Services.Catalog.Settings;

namespace MultiShop.Services.Catalog.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<Product> _productCollection;

        public ProductService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _productCollection = database.GetCollection<Product>(_databaseSettings.ProductCollectionName);
            _mapper = mapper;
        }

        public async Task CreateProductAsync(CreateProductDTO createProductDTO)
        {
            var values = _mapper.Map<Product>(createProductDTO);
            await _productCollection.InsertOneAsync(values);
        }

        public async Task DeleteProductAsync(string id)
        {
            await _productCollection.DeleteOneAsync(x => x.ProductID == id);
        }

        public async Task<List<ResultProductDTO>> GetAllActiveProductAsync()
        {
            var values = await _productCollection.Find(x => x.IsDeleted == true).ToListAsync();
            return _mapper.Map<List<ResultProductDTO>>(values);
        }

        public async Task<GetByIdProductDTO> GetByIdProductAsync(string id)
        {
            var values = await _productCollection.Find<Product>(x => x.ProductID == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdProductDTO>(values);
        }

        public async Task<List<ResultProductDTO>> GettAllProductAsync()
        {
            var values = await _productCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultProductDTO>>(values);
        }

        public async Task UpdateHomeStatusAsync(string id)
        {
            var values = await _productCollection.Find<Product>(x => x.ProductID == id).FirstOrDefaultAsync();
            if (values.IsHome == false)
                values.IsHome = true;
            else
                values.IsHome = false;
            await _productCollection.FindOneAndReplaceAsync(x => x.ProductID == id, values);
        }

        public async Task UpdateProductAsync(UpdateProductDTO updateProductDTO)
        {
            var values = _mapper.Map<Product>(updateProductDTO);
            await _productCollection.FindOneAndReplaceAsync(x => x.ProductID == updateProductDTO.ProductID, values);
        }

        public async Task UpdateProductStatusAsync(string id)
        {
            var values = await _productCollection.Find<Product>(x => x.ProductID == id).FirstOrDefaultAsync();
            if (values.IsDeleted == false)
                values.IsDeleted = true;
            else
                values.IsDeleted = false;
            await _productCollection.FindOneAndReplaceAsync(x => x.ProductID == id, values);
        }
    }
}