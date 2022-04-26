﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MEalAPI.Models
{
    [Table("recipes", Schema = "MEal")]
    public class Recipe
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public int? PrepTime { get; set; }

        public int? CookTime { get; set; }

        // Foreign Key Relations
        public List<RecipeIngredient>? RecipeIngredients { get; set; }

        public List<RecipeStep>? RecipeSteps { get; set; }
    }
}
