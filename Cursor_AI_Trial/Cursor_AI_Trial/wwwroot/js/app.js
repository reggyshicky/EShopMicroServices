document.addEventListener('DOMContentLoaded', async () => {
    const moodSelect = document.getElementById('moodSelect');
    const findRecipeBtn = document.getElementById('findRecipe');
    const tryAnotherBtn = document.getElementById('tryAnother');
    const recipeCard = document.getElementById('recipeCard');

    // Load moods when page loads
    try {
        const response = await fetch('/api/recipe/moods');
        const moods = await response.json();
        moods.forEach(mood => {
            const option = document.createElement('option');
            option.value = mood.moodId;
            option.textContent = mood.moodName;
            moodSelect.appendChild(option);
        });
    } catch (error) {
        console.error('Error loading moods:', error);
    }

    async function loadRecipe() {
        const moodId = moodSelect.value;
        if (!moodId) return;

        try {
            const response = await fetch(`/api/recipe/${moodId}`);
            const recipe = await response.json();

            document.getElementById('recipeTitle').textContent = recipe.title;
            document.getElementById('recipeDescription').textContent = recipe.description;
            document.getElementById('recipeIngredients').textContent = recipe.ingredients;
            document.getElementById('recipeInstructions').textContent = recipe.instructions;

            recipeCard.classList.remove('hidden');
        } catch (error) {
            console.error('Error loading recipe:', error);
        }
    }

    findRecipeBtn.addEventListener('click', loadRecipe);
    tryAnotherBtn.addEventListener('click', loadRecipe);
}); 