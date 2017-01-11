using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FesbBoard.Domain.Queries;
using entities = FesbBoard.Domain.Entities;

namespace FesbBoard.Controllers
{
    [Route("api/[controller]")]
    public class BoardsController : Controller
    {
        public BoardsController(IBoardQueries boards)
        {
            Boards = boards;
        }
        public IBoardQueries Boards { get; set; }

        [Route("all")]
        [HttpGet]
        public IReadOnlyCollection<entities.Board> GetAll()
        {
            return Boards.GetAll();
        }
    }
}
