using AutoMapper;
using MongoDB.Driver;
using MultiShop.Services.Catalog.DTOs.CategoryDTOs;
using MultiShop.Services.Catalog.Entities;
using MultiShop.Services.Catalog.Settings;

namespace MultiShop.Services.Catalog.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly IMongoCollection<Category> _categoryCollection;
        private readonly IMapper _mapper;

        public CategoryService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _categoryCollection = database.GetCollection<Category>(_databaseSettings.CategoryCollectionName);
            _mapper = mapper;
        }
        
        public async Task CreateCategoryAsync(CreateCategoryDTO createCategoryDTO)
        {
            var value = _mapper.Map<Category>(createCategoryDTO);
            await _categoryCollection.InsertOneAsync(value);
        }

        public async Task DeleteCategoryAsync(string id)
        {
            await _categoryCollection.DeleteOneAsync(x => x.CategoryID == id);
        }

        public async Task<GetByIdCategoryDTO> GetByIdCategoryAsync(string id)
        {
            var values = await _categoryCollection.Find<Category>(x => x.CategoryID == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdCategoryDTO>(values);
        }

        public async Task<List<ResultCategoryDTO>> GetAllActiveCategoryAsync()
        {
            var values = await _categoryCollection.Find(x => x.IsDeleted == true).ToListAsync();
            return _mapper.Map<List<ResultCategoryDTO>>(values);
        }

        public async Task<List<ResultCategoryDTO>> GetAllCategoryAsync()
        {
            var values = await _categoryCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultCategoryDTO>>(values);
        }

        public async Task UpdateCategoryAsync(UpdateCategoryDTO updateCategoryDTO)
        {
            var values = _mapper.Map<Category>(updateCategoryDTO);
            await _categoryCollection.FindOneAndReplaceAsync(x => x.CategoryID == updateCategoryDTO.CategoryID, values);
        }

        public async Task UpdateCategoryStatusAsync(string id)
        {
            var values = await _categoryCollection.Find<Category>(x => x.CategoryID == id).FirstOrDefaultAsync();
            if (values.IsDeleted == false)
                values.IsDeleted = true;
            else
                values.IsDeleted = false;
            await _categoryCollection.FindOneAndReplaceAsync(x => x.CategoryID == id, values);
        }

        public async Task UpdateHomeStatusAsync(string id)
        {
            var values = await _categoryCollection.Find<Category>(x => x.CategoryID == id).FirstOrDefaultAsync();
            if (values.IsHome == false)
                values.IsHome = true;
            else
                values.IsHome = false;
            await _categoryCollection.FindOneAndReplaceAsync(x => x.CategoryID == id, values);
        }
    }
}