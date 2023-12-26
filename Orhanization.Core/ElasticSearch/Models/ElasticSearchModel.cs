using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orhanization.Core.ElasticSearch.Models;

public class ElasticSearchModel
{
    public Id ElasticId { get; set; }
    public string IndexName { get; set; }

    public ElasticSearchModel()
    {
        ElasticId = null!;
        IndexName = string.Empty;
    }

    public ElasticSearchModel(Id elasticId, string indexName)
    {
        ElasticId = elasticId;
        IndexName = indexName;
    }
}
