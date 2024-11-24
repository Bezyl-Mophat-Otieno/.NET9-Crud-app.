using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoGameApi.Database;
using VideoGameApi.Models;

namespace VideoGameApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VideoGameController: ControllerBase
{
    private VideoGameDbContext _dbContext;
    private readonly  ILogger<VideoGameController> _logger;

    public VideoGameController( ILogger<VideoGameController> logger, VideoGameDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult<List<VideoGame>>> GetVideoGames()
    {
        _logger.LogInformation("GetVideoGames");
        return Ok(await _dbContext.VideoGames.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task <ActionResult<VideoGame?>> GetVideoGameById(int id)
    {
        _logger.LogInformation("GetVideoGameById");
        var videoGame = await _dbContext.VideoGames.FindAsync(id);
        if (videoGame is null) return NotFound();
        return videoGame;
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<VideoGame>> UpdateVideoGame(int id, [FromBody] VideoGame updatedVideoGame)
    {
        _logger.LogInformation("UpdateVideoGame");
        var currentVideoGame = await _dbContext.VideoGames.FindAsync(id);
        if (currentVideoGame is null) return NotFound();
        currentVideoGame.Title = updatedVideoGame.Title;
        currentVideoGame.Platform = updatedVideoGame.Platform;
        currentVideoGame.Publisher = updatedVideoGame.Publisher;
        currentVideoGame.Developer = updatedVideoGame.Developer;
        await _dbContext.SaveChangesAsync();
        return Ok(currentVideoGame);
    }

    [HttpPost]
    public async Task<ActionResult<List<VideoGame>>>CreateVideoGame([FromBody] VideoGame videoGame)
    {
        _logger.LogInformation("CreateVideoGame");
        await _dbContext.VideoGames.AddAsync(videoGame);
        await _dbContext.SaveChangesAsync();
        return CreatedAtAction(nameof(GetVideoGameById), new { id = videoGame.Id }, videoGame);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<VideoGame>> DeleteVideoGame(int id)
    {
        var targetVideoGame = await _dbContext.VideoGames.FindAsync(id);
        if (targetVideoGame is null) return NotFound();
        _dbContext.Remove(targetVideoGame);
        var success = await _dbContext.SaveChangesAsync() > 0;
        if (success) return Ok($"Video Game with Id { id } deleted successfully");
        return BadRequest();
    }
}