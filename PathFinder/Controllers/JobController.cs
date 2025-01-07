using Microsoft.AspNetCore.Mvc;
using PathFinder.Services.Data.Interfaces;

namespace PathFinder.Controllers
{
    public class JobController(
        IJobService jobService,
        ILogger<JobController> logger): Controller
    {

    }
}
