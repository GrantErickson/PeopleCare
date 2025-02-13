
using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Api;
using IntelliTect.Coalesce.Api.Behaviors;
using IntelliTect.Coalesce.Api.Controllers;
using IntelliTect.Coalesce.Api.DataSources;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Mapping.IncludeTrees;
using IntelliTect.Coalesce.Models;
using IntelliTect.Coalesce.TypeDefinition;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeopleCare.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PeopleCare.Web.Api
{
    [Route("api/PersonPersonType")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class PersonPersonTypeController
        : BaseApiController<PeopleCare.Data.Models.PersonPersonType, PersonPersonTypeParameter, PersonPersonTypeResponse, PeopleCare.Data.AppDbContext>
    {
        public PersonPersonTypeController(CrudContext<PeopleCare.Data.AppDbContext> context) : base(context)
        {
            GeneratedForClassViewModel = context.ReflectionRepository.GetClassViewModel<PeopleCare.Data.Models.PersonPersonType>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<PersonPersonTypeResponse>> Get(
            string id,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<PeopleCare.Data.Models.PersonPersonType> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<PersonPersonTypeResponse>> List(
            [FromQuery] ListParameters parameters,
            IDataSource<PeopleCare.Data.Models.PersonPersonType> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            [FromQuery] FilterParameters parameters,
            IDataSource<PeopleCare.Data.Models.PersonPersonType> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Consumes("application/x-www-form-urlencoded", "multipart/form-data")]
        [Authorize]
        public virtual Task<ItemResult<PersonPersonTypeResponse>> Save(
            [FromForm] PersonPersonTypeParameter dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<PeopleCare.Data.Models.PersonPersonType> dataSource,
            IBehaviors<PeopleCare.Data.Models.PersonPersonType> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("save")]
        [Consumes("application/json")]
        [Authorize]
        public virtual Task<ItemResult<PersonPersonTypeResponse>> SaveFromJson(
            [FromBody] PersonPersonTypeParameter dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<PeopleCare.Data.Models.PersonPersonType> dataSource,
            IBehaviors<PeopleCare.Data.Models.PersonPersonType> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("bulkSave")]
        [Authorize]
        public virtual Task<ItemResult<PersonPersonTypeResponse>> BulkSave(
            [FromBody] BulkSaveRequest dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<PeopleCare.Data.Models.PersonPersonType> dataSource,
            [FromServices] IDataSourceFactory dataSourceFactory,
            [FromServices] IBehaviorsFactory behaviorsFactory)
            => BulkSaveImplementation(dto, parameters, dataSource, dataSourceFactory, behaviorsFactory);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<PersonPersonTypeResponse>> Delete(
            string id,
            IBehaviors<PeopleCare.Data.Models.PersonPersonType> behaviors,
            IDataSource<PeopleCare.Data.Models.PersonPersonType> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}
