using System.Collections.Generic;
using System.Threading.Tasks;

namespace GettyImages.Connect.Search
{
    public interface IImagesSearch
    {
        Task<dynamic> ExecuteAsync();
        SearchImages WithPage(int val);
        SearchImages WithPageSize(int val);
        SearchImages WithPhrase(string val);
        SearchImages WithSortOrder(string val);
        SearchImages WithEmbedContentOnly(bool value = true);
        SearchImages WithExcludeNudity(bool value = true);
        SearchImages WithResponseField(string value);
        SearchImages WithResponseFields(IList<string> value);
        SearchImages WithGraphicalStyle(GraphicalStyles value);
        SearchImages WithOrientation(Orientation value);
    }
}