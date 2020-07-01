﻿using EIMRentaaCar.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace EIMRentaaCar.Models
{
    public class Vehiculos
    {
        [Key]
        [Required(ErrorMessage = "El campo Id debe ser un numero")]
        [Range(0, 100000000, ErrorMessage = "El campo Id no puede ser menor que cero")]
        public int VehiculoId { get; set; }

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }

        public VehiculoEstado Estado { get; set; }

        [Required(ErrorMessage ="El campo tipo no puede estar vacio")]
        [RegularExpression(@"\S(.*)\S", ErrorMessage = "Debe ser un texto.")]
        public string Tipo { get; set; }

        [Required(ErrorMessage ="No puede estar vació el campo modelo")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "No puede estar vació el campo marca")]
        public string Marca { get; set; }

        [RegularExpression("^[0-9]", ErrorMessage = "Debe ser numeros")]
        [Required(ErrorMessage = "No puede estar vació el campo VIN")]
        public int Vin { get; set; }

        [RegularExpression("^[0-9]", ErrorMessage = "Debe ser numeros")]
        [Required(ErrorMessage = "No puede estar vació el campo año")]
        public int Año { get; set; }

        [RegularExpression("^[0-9]", ErrorMessage = "Debe ser numeros")]
        [Required(ErrorMessage = "No puede estar vació el campo precio de venta")]
        public decimal PrecioVenta { get; set; }

        [RegularExpression("^[0-9]", ErrorMessage = "Debe ser numeros")]
        [Required(ErrorMessage = "No puede estar vació el campo precio por dia")]
        public decimal PrecioPorDia { get; set; }

        [RegularExpression("^[0-9]", ErrorMessage = "Debe ser numeros")]
        [Required(ErrorMessage = "No puede estar vació el campo Kilometraje")]
        public int Kilometraje { get; set; }

        [ForeignKey("ImportadorId")]
        public int ImportadorId { get; set; }

        public Vehiculos()
        {
            VehiculoId = 0;
            UsuarioId = 0;
            Estado = VehiculoEstado.Disponible;
            Tipo = string.Empty;
            Modelo = string.Empty;
            Marca = string.Empty;
            Vin = 0;
            Año = 0;
            PrecioVenta = 0.0m;
            PrecioPorDia = 0.0m;
            Kilometraje = 0;
            ImportadorId = 0;
        }

        public Vehiculos(int vehiculoId, int usuarioId, VehiculoEstado estado, string tipo, string modelo, string marca, int vin, int año, decimal precioVenta, decimal precioPorDia, int kilometraje, int importadorId)
        {
            VehiculoId = vehiculoId;
            UsuarioId = usuarioId;
            Estado = estado;
            Tipo = tipo ?? throw new ArgumentNullException(nameof(tipo));
            Modelo = modelo ?? throw new ArgumentNullException(nameof(modelo));
            Marca = marca ?? throw new ArgumentNullException(nameof(marca));
            Vin = vin;
            Año = año;
            PrecioVenta = precioVenta;
            PrecioPorDia = precioPorDia;
            Kilometraje = kilometraje;
            ImportadorId = importadorId;
        }
    }
}
