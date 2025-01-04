namespace Cursor_AI_Trial.Controllers;
using Microsoft.AspNetCore.Mvc;
using Cursor_AI_Trial.Models;
using Cursor_AI_Trial.Data;
using Microsoft.EntityFrameworkCore;

public class RecipeController : Controller
{
    private readonly ApplicationDbContext _context;

    public RecipeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var moods = await _context.Moods.ToListAsync();
        return View(moods);
    }

    public async Task<IActionResult> GetRecipeByMood(int moodId)
    {
        var recipe = await _context.Recipes
            .Include(r => r.Mood)
            .Where(recipe => recipe.MoodId == moodId)
            .OrderBy(r => EF.Functions.Random())
            .FirstOrDefaultAsync();
        if (recipe == null)
            return NotFound();

        return View(recipe);
    }
}
