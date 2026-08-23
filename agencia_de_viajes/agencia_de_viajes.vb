Imports System
Module agencia_de_viajes
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim clientes(9) As String
        Dim destinos(9) As String
        Dim fechasSalida(9) As String
        Dim fechasRegreso(9) As String
        Dim transportes(9) As String
        Dim pasajeros(9) As Integer
        Dim preciosPasajero(9) As Double
        Dim costosTotales(9) As Double
        Dim estados(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '--------------------------------------//
        '--|menu_principal_agencia_de_viajes|--//
        '--------------------------------------//
        Do
            Console.WriteLine("menu principal agencia de viajes")
            Console.WriteLine("1) Registrar reserva")
            Console.WriteLine("2) Editar reserva")
            Console.WriteLine("3) Listar reservas")
            Console.WriteLine("4) Buscar reserva")
            Console.WriteLine("5) Eliminar reserva")
            Console.WriteLine("6) Mostrar resumen")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '-----------------------//
                '--|registrar_reserva|--//
                '-----------------------//
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas reservas.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.WriteLine("registro de reserva")
                        Console.Write("Cliente: ")
                        clientes(cantidad) = Console.ReadLine()
                        Console.Write("Destino: ")
                        destinos(cantidad) = Console.ReadLine()
                        Console.Write("Fecha de salida: ")
                        fechasSalida(cantidad) = Console.ReadLine()
                        Console.Write("Fecha de regreso: ")
                        fechasRegreso(cantidad) = Console.ReadLine()
                        Console.Write("Transporte: ")
                        transportes(cantidad) = Console.ReadLine()
                        Console.Write("Cantidad de pasajeros: ")
                        pasajeros(cantidad) = Convert.ToInt32(Console.ReadLine())
                        Console.Write("Precio por pasajero: ")
                        preciosPasajero(cantidad) = Convert.ToDouble(Console.ReadLine())
                        costosTotales(cantidad) = pasajeros(cantidad) * preciosPasajero(cantidad)
                        Console.Write("Estado: ")
                        estados(cantidad) = Console.ReadLine()
                        cantidad += 1
                        Console.WriteLine("Reserva registrada correctamente.")
                        Console.WriteLine("Costo total: " & costosTotales(cantidad - 1))
                    End If
                '--------------------//
                '--|editar_reserva|--//
                '--------------------//
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen reservas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Cliente: " & clientes(i) & " | Destino: " & destinos(i) & " | Fecha salida: " & fechasSalida(i) & " | Fecha regreso: " & fechasRegreso(i) & " | Transporte: " & transportes(i) & " | Pasajeros: " & pasajeros(i) & " | Precio pasajero: " & preciosPasajero(i) & " | Costo total: " & costosTotales(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID de la reserva a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo cliente: ")
                            clientes(posicion) = Console.ReadLine()
                            Console.Write("Nuevo destino: ")
                            destinos(posicion) = Console.ReadLine()
                            Console.Write("Nueva fecha de salida: ")
                            fechasSalida(posicion) = Console.ReadLine()
                            Console.Write("Nueva fecha de regreso: ")
                            fechasRegreso(posicion) = Console.ReadLine()
                            Console.Write("Nuevo transporte: ")
                            transportes(posicion) = Console.ReadLine()
                            Console.Write("Nueva cantidad de pasajeros: ")
                            pasajeros(posicion) = Convert.ToInt32(Console.ReadLine())
                            Console.Write("Nuevo precio por pasajero: ")
                            preciosPasajero(posicion) = Convert.ToDouble(Console.ReadLine())
                            costosTotales(posicion) = pasajeros(posicion) * preciosPasajero(posicion)
                            Console.Write("Nuevo estado: ")
                            estados(posicion) = Console.ReadLine()
                            Console.WriteLine("Reserva actualizada correctamente.")
                            Console.WriteLine("Nuevo costo total: " & costosTotales(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------//
                '--|listar_reservas|--//
                '---------------------//
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen reservas registradas.")
                    Else
                        Console.WriteLine("lista de reservas")
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Cliente: " & clientes(i) & " | Destino: " & destinos(i) & " | Fecha salida: " & fechasSalida(i) & " | Fecha regreso: " & fechasRegreso(i) & " | Transporte: " & transportes(i) & " | Pasajeros: " & pasajeros(i) & " | Precio pasajero: " & preciosPasajero(i) & " | Costo total: " & costosTotales(i) & " | Estado: " & estados(i))
                        Next
                    End If
                '--------------------//
                '--|buscar_reserva|--//
                '--------------------//
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen reservas registradas.")
                    Else
                        Console.Write("Ingrese el ID de la reserva a buscar: ")
                        Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idBuscar >= 1 And idBuscar <= cantidad Then
                            Dim posicion As Integer = idBuscar - 1
                            Console.WriteLine("reserva encontrada")
                            Console.WriteLine("ID: " & ids(posicion) & " | Cliente: " & clientes(posicion) & " | Destino: " & destinos(posicion) & " | Fecha salida: " & fechasSalida(posicion) & " | Fecha regreso: " & fechasRegreso(posicion) & " | Transporte: " & transportes(posicion) & " | Pasajeros: " & pasajeros(posicion) & " | Precio pasajero: " & preciosPasajero(posicion) & " | Costo total: " & costosTotales(posicion) & " | Estado: " & estados(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '----------------------//
                '--|eliminar_reserva|--//
                '----------------------//
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen reservas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Cliente: " & clientes(i) & " | Destino: " & destinos(i) & " | Fecha salida: " & fechasSalida(i) & " | Fecha regreso: " & fechasRegreso(i) & " | Transporte: " & transportes(i) & " | Pasajeros: " & pasajeros(i) & " | Precio pasajero: " & preciosPasajero(i) & " | Costo total: " & costosTotales(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID de la reserva a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                clientes(i) = clientes(i + 1)
                                destinos(i) = destinos(i + 1)
                                fechasSalida(i) = fechasSalida(i + 1)
                                fechasRegreso(i) = fechasRegreso(i + 1)
                                transportes(i) = transportes(i + 1)
                                pasajeros(i) = pasajeros(i + 1)
                                preciosPasajero(i) = preciosPasajero(i + 1)
                                costosTotales(i) = costosTotales(i + 1)
                                estados(i) = estados(i + 1)
                            Next
                            cantidad -= 1
                            Console.WriteLine("Reserva eliminada correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------//
                '--|mostrar_resumen|--//
                '---------------------//
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen reservas registradas.")
                    Else
                        Dim pendientes As Integer = 0
                        Dim confirmadas As Integer = 0
                        Dim pagadas As Integer = 0
                        Dim canceladas As Integer = 0
                        Dim finalizadas As Integer = 0
                        Dim totalPasajeros As Integer = 0
                        Dim ingresosTotales As Double = 0
                        For i As Integer = 0 To cantidad - 1
                            If estados(i).ToLower() = "pendiente" Then
                                pendientes += 1
                            ElseIf estados(i).ToLower() = "confirmada" Then
                                confirmadas += 1
                            ElseIf estados(i).ToLower() = "pagada" Then
                                pagadas += 1
                            ElseIf estados(i).ToLower() = "cancelada" Then
                                canceladas += 1
                            ElseIf estados(i).ToLower() = "finalizada" Then
                                finalizadas += 1
                            End If
                            totalPasajeros += pasajeros(i)
                            ingresosTotales += costosTotales(i)
                        Next
                        Dim promedio As Double = ingresosTotales / cantidad
                        Console.WriteLine("resumen de agencia de viajes")
                        Console.WriteLine("Reservas: " & cantidad & " | Pendientes: " & pendientes & " | Confirmadas: " & confirmadas & " | Pagadas: " & pagadas & " | Canceladas: " & canceladas & " | Finalizadas: " & finalizadas & " | Pasajeros: " & totalPasajeros & " | Ingresos totales: " & ingresosTotales & " | Promedio por reserva: " & Math.Round(promedio, 2))
                    End If
                '------------------------------//
                '--|salir_del_menu_principal|--//
                '------------------------------//
                Case 7
                    Console.WriteLine("Gracias por utilizar Agencia de Viajes.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module