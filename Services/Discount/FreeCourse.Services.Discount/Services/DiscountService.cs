using Dapper;
using FreeCourse.Shared.Dtos;
using Npgsql;
using System.Data;
using System.Runtime.InteropServices;

namespace FreeCourse.Services.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly IConfiguration _configuration;
        private readonly IDbConnection _dbConnection;

        public DiscountService(IConfiguration configuration)
        {
            _configuration = configuration;

            _dbConnection = new NpgsqlConnection(_configuration.GetConnectionString("PostgreSql"));
        }

        public Task<Response<NoContent>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<List<Models.Discount>>> GetAll()
        {
            var discounts = await _dbConnection.QueryAsync<Models.Discount>("select * from discount");
            return Response<List<Models.Discount>>.Success(discounts.ToList(), 200);
        }

        public Task<Response<Models.Discount>> GetByCodeAndUserId(string code, string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<Models.Discount>> GetById(int id)
        {
            var discount = (await _dbConnection.QueryAsync<Models.Discount>("select * from discount where id=@Id", new { Id = id })).SingleOrDefault();

            if (discount == null)
                return Response<Models.Discount>.Fail("Discount not found", 404);

            return Response<Models.Discount>.Success(discount, 200);
        }

        public Task<Response<NoContent>> Save(Models.Discount discount)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> Update(Models.Discount discount)
        {
            throw new NotImplementedException();
        }
    }
}
