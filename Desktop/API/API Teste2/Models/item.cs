using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace Mvc_MongoDB.Models
{
    public class Item
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; }

        [Required, 
        StringLength(50, ErrorMessage = "Número inválido de caracteres", MinimumLength =10), 
        Display(Name = "Nome")]
        public String NomeItem { get; set; }


        [Required]
        [Display(Name = "Categoria")]
        public String CategoriaItem { get; set; }

        [Required]
        [Display(Name = "Quantidade")]
        public double QuantidadeItem { get; set; }
        //StringSplitOptions; 
    }
}