namespace CQRS.Queries
{
    public class ProductQuery : BaseQuery<ProductIdRequest, ProductEntity>
    {
        public override ProductEntity Execute(ProductIdRequest input)
        {
            //using (var cmd = new OracleDbProvider(StoredProcedure.GetProduct))
            //{
            //    cmd.AddInParameter("i_tenant_id", tenantId);
            //    using (var rdr = cmd.ExecuteReader())
            //    {
            //        if (rdr.Read())
            //        {
            //            return new ProductEntity
            //            {
            //                //ProductName = SqlUtil.SetValue(rdr["productname"], 0),
            //            };
            //        }
            //    }
            //}

            return default(ProductEntity);
        }
    }
}
