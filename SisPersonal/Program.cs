// See https://aka.ms/new-console-template for more information
using espacioEmpleado;
using System.Diagnostics.Contracts;
using System;
using System.Linq;
    
Empleado[] empleados = new Empleado[3];

        empleados[0] = new Empleado
        {
            Nombre = "Carlos",
            Apellido = "Gómez",
            FechaNacimiento = new DateTime(1970, 5, 12),
            EstadoCivil = 'C',
            FechaIngreso = new DateTime(2000, 3, 15),
            SueldoBasico = 650000,
            Cargo = Cargos.Ingeniero
        };

        empleados[1] = new Empleado
        {
            Nombre = "Lucía",
            Apellido = "Martínez",
            FechaNacimiento = new DateTime(1985, 8, 23),
            EstadoCivil = 'S',
            FechaIngreso = new DateTime(2010, 7, 10),
            SueldoBasico = 580000,
            Cargo = Cargos.Administrativo
        };

        empleados[2] = new Empleado
        {
            Nombre = "Juan",
            Apellido = "Pérez",
            FechaNacimiento = new DateTime(1990, 1, 10),
            EstadoCivil = 'C',
            FechaIngreso = new DateTime(2015, 9, 1),
            SueldoBasico = 600000,
            Cargo = Cargos.Especialista
        };

        double totalSalarios = empleados.Sum(emp => emp.Salario);
        Console.WriteLine($"Total en concepto de salarios: ${totalSalarios:N2}\n");


Empleado proximoAJubilarse = empleados.OrderBy(emp => emp.AniosParaJubilarse).First();

        Console.WriteLine("Empleado más próximo a jubilarse:");
        Console.WriteLine($"Nombre: {proximoAJubilarse.Nombre} {proximoAJubilarse.Apellido}");
        Console.WriteLine($"Edad: {proximoAJubilarse.Edad} años");
        Console.WriteLine($"Antigüedad: {proximoAJubilarse.Antiguedad} años");
        Console.WriteLine($"Años para jubilarse: {proximoAJubilarse.AniosParaJubilarse}");
        Console.WriteLine($"Salario: ${proximoAJubilarse.Salario:N2}");

