﻿using evaluacion2api.Models;
using Microsoft.AspNetCore.Mvc;

namespace evaluacion2api.Responses
{
    /*retorna una Proyecto*/
    public class ProyectoResponse : ResponseBase<Proyecto>
    {
    }

    /*retorna una lista de Proyectos*/
    public class ProyectosResponse : ResponseBase<List<Proyecto>>
    {
    }

    public class NuevoProyectoResponse : ResponseBase<bool>
    {
    }
    public class UpdateProyectoResponse : ResponseBase<bool>
    {
    }

    public class DeleteProyectoResponse : ResponseBase<bool>
    {
    }

    }
