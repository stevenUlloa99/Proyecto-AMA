﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using FundacionAMA.Domain.Shared.Entities;

using System;
using System.Collections.Generic;

namespace FundacionAMA.Domain.Entities;
/// <summary>
/// Modelo de la base de datos para la tabla Donation
/// </summary>
public partial class Donation: BaseEntity<int>
{
    /// <summary>
    /// Nombre de la donacion
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// tipo de donacion
    /// </summary>
    public int? DonationTypeId { get; set; }
    /// <summary>
    /// precio de la donacion
    /// </summary>
    public decimal? Price { get; set; }
    /// <summary>
    /// total de la donacion
    /// </summary>
    public decimal? Total { get; set; }
    /// <summary>
    /// persona que dona
    /// </summary>
    public int? PersonId { get; set; }
    //modifico yo
    /// <summary>
    /// persona que dona
    /// </summary>
    public string? Identification { get; set; }
    //
    /// <summary>
    /// brigada que recibe la donacion
    /// </summary>
    public int? BrigadeId { get; set; }
    /// <summary>
    /// cantidad de donaciones
    /// </summary>
    public int Amount { get; set; } = 0;
    /// <summary>
    /// status de la donacion
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// relacion con la tabla brigada
    /// </summary>
    public virtual Brigade Brigade { get; set; }
    /// <summary>
    /// relacion con la tabla tipo de donacion
    /// </summary>
    public virtual DonationType DonationType { get; set; }
    /// <summary>
    /// relacion con el donante
    /// </summary>
    public virtual Donor Person { get; set; }
    /// <summary>
    /// fecha de donación
    /// </summary>
    public DateTime AssignedAt { get; set; }
}