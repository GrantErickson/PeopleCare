
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
    [Route("api/Relationship")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class RelationshipController
        : BaseApiController<PeopleCare.Data.Models.Relationship, RelationshipParameter, RelationshipResponse, PeopleCare.Data.AppDbContext>
    {
        public RelationshipController(CrudContext<PeopleCare.Data.AppDbContext> context) : base(context)
        {
            GeneratedForClassViewModel = context.ReflectionRepository.GetClassViewModel<PeopleCare.Data.Models.Relationship>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<RelationshipResponse>> Get(
            string id,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<PeopleCare.Data.Models.Relationship> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<RelationshipResponse>> List(
            [FromQuery] ListParameters parameters,
            IDataSource<PeopleCare.Data.Models.Relationship> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            [FromQuery] FilterParameters parameters,
            IDataSource<PeopleCare.Data.Models.Relationship> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Consumes("application/x-www-form-urlencoded", "multipart/form-data")]
        [Authorize]
        public virtual Task<ItemResult<RelationshipResponse>> Save(
            [FromForm] RelationshipParameter dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<PeopleCare.Data.Models.Relationship> dataSource,
            IBehaviors<PeopleCare.Data.Models.Relationship> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("save")]
        [Consumes("application/json")]
        [Authorize]
        public virtual Task<ItemResult<RelationshipResponse>> SaveFromJson(
            [FromBody] RelationshipParameter dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<PeopleCare.Data.Models.Relationship> dataSource,
            IBehaviors<PeopleCare.Data.Models.Relationship> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("bulkSave")]
        [Authorize]
        public virtual Task<ItemResult<RelationshipResponse>> BulkSave(
            [FromBody] BulkSaveRequest dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<PeopleCare.Data.Models.Relationship> dataSource,
            [FromServices] IDataSourceFactory dataSourceFactory,
            [FromServices] IBehaviorsFactory behaviorsFactory)
            => BulkSaveImplementation(dto, parameters, dataSource, dataSourceFactory, behaviorsFactory);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<RelationshipResponse>> Delete(
            string id,
            IBehaviors<PeopleCare.Data.Models.Relationship> behaviors,
            IDataSource<PeopleCare.Data.Models.Relationship> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);

        // Methods from data class exposed through API Controller.

        /// <summary>
        /// Method: Create
        /// </summary>
        [HttpPost("Create")]
        [Authorize]
        [Consumes("application/x-www-form-urlencoded", "multipart/form-data")]
        public virtual ItemResult<RelationshipResponse> Create(
            [FromForm(Name = "person")] PersonParameter person,
            [FromForm(Name = "relatedPerson")] PersonParameter relatedPerson,
            [FromForm(Name = "relationshipTypeId")] string relationshipTypeId)
        {
            var _params = new
            {
                Person = !Request.Form.HasAnyValue(nameof(person)) ? null : person,
                RelatedPerson = !Request.Form.HasAnyValue(nameof(relatedPerson)) ? null : relatedPerson,
                RelationshipTypeId = relationshipTypeId
            };

            if (Context.Options.ValidateAttributesForMethods)
            {
                var _validationResult = ItemResult.FromParameterValidation(
                    GeneratedForClassViewModel!.MethodByName("Create"), _params, HttpContext.RequestServices);
                if (!_validationResult.WasSuccessful) return new ItemResult<RelationshipResponse>(_validationResult);
            }

            IncludeTree includeTree = null;
            var _mappingContext = new MappingContext(Context);
            var _methodResult = PeopleCare.Data.Models.Relationship.Create(
                _params.Person?.MapToNew(_mappingContext),
                _params.RelatedPerson?.MapToNew(_mappingContext),
                _params.RelationshipTypeId,
                Db
            );
            var _result = new ItemResult<RelationshipResponse>();
            _result.Object = Mapper.MapToDto<PeopleCare.Data.Models.Relationship, RelationshipResponse>(_methodResult, _mappingContext, includeTree);
            return _result;
        }

        public class RelationshipCreateParameters
        {
            public PersonParameter Person { get; set; }
            public PersonParameter RelatedPerson { get; set; }
            public string RelationshipTypeId { get; set; }
        }

        /// <summary>
        /// Method: Create
        /// </summary>
        [HttpPost("Create")]
        [Authorize]
        [Consumes("application/json")]
        public virtual ItemResult<RelationshipResponse> Create(
            [FromBody] RelationshipCreateParameters _params
        )
        {
            if (Context.Options.ValidateAttributesForMethods)
            {
                var _validationResult = ItemResult.FromParameterValidation(
                    GeneratedForClassViewModel!.MethodByName("Create"), _params, HttpContext.RequestServices);
                if (!_validationResult.WasSuccessful) return new ItemResult<RelationshipResponse>(_validationResult);
            }

            IncludeTree includeTree = null;
            var _mappingContext = new MappingContext(Context);
            var _methodResult = PeopleCare.Data.Models.Relationship.Create(
                _params.Person?.MapToNew(_mappingContext),
                _params.RelatedPerson?.MapToNew(_mappingContext),
                _params.RelationshipTypeId,
                Db
            );
            var _result = new ItemResult<RelationshipResponse>();
            _result.Object = Mapper.MapToDto<PeopleCare.Data.Models.Relationship, RelationshipResponse>(_methodResult, _mappingContext, includeTree);
            return _result;
        }
    }
}
