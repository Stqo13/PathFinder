using Microsoft.Extensions.Hosting;
using PathFinder.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml;

namespace PathFinder.Data.Models
{
    public class Recommendation
    {
        //      RecommendationID: Unique identifier.
        //      UserID: Associated user ID.
        //      ItemID: Associated course, job, or class.
        //      Type: Course, job, or class.
        //      GeneratedOn: Date of recommendation generation.
        //      RelevanceScore: AI-calculated relevance.
        //      Mode: Online or in-person recommendation.
        //      Location: In-person location (for courses/jobs).
        //      Category: Career field(IT, Arts, etc.).
        //      CostRange: Range for course/job cost.
    }
}
