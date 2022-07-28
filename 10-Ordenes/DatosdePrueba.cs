using System;
using System.Collections.Generic;
public class DatosdePrueba
{
    public List<Producto> ListadeProductos { get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Vendedor> ListadeVendedores { get; set; }
    public List<Orden> ListaOrdenes { get; set; }

    public DatosdePrueba()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeVendedores = new List<Vendedor>();
        cargarVendedores();

        ListaOrdenes = new List<Orden>();
    }

    private void cargarProductos()
    {
        Producto p1 = new Producto(1, "HP impresora ", 5600);
        ListadeProductos.Add(p1);

        Producto p2 = new Producto(2, "Laptop Dell inspiron", 22000);
        ListadeProductos.Add(p2);

        Producto p3 = new Producto(3, " telefono samsung z-flip ", 12100);
        ListadeProductos.Add(p3);

        Producto p4 = new Producto(4, " aspiradora Vacmaster ", 675);
        ListadeProductos.Add(p4);

        Producto p5 = new Producto(5, " galletas ", 579);
        ListadeProductos.Add(p5);

        Producto p6 = new Producto(6, " Airwrap dyson ", 4300);
        ListadeProductos.Add(p6);
    }

    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1, " Medina Astrid ", "52-55-892-3723");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente(2, " Doña Elsa ", "+1 567-345-1289");
        ListadeClientes.Add(c2);

        Cliente c3 = new Cliente(3, " la chismosa de la esquina :v ", "504+9834-5678");
        ListadeClientes.Add(c3);
    }

    private void cargarVendedores()
    {
        Vendedor v1 = new Vendedor(1, "Adrian Aguilera", "V0001");
        ListadeVendedores.Add(v1);

        Vendedor v2 = new Vendedor(2, "Mariana Duron", "V0002");
        ListadeVendedores.Add(v2);
    }

    public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("~(^v^~)*-.(^v^).-*(~^v^)~");
        Console.WriteLine("=°.°= Lista de Productos =°-°=");
        Console.WriteLine("~(^v^~)*-.(^v^).-*(~^v^)~");
        Console.WriteLine("");
        
        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);
        }

        Console.ReadLine();
    }

    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("~(^v^~)*-.(^v^).-*(~^v^)~");
        Console.WriteLine("= Lista de Clientes =");
        Console.WriteLine("~(^v^~)*-.(^v^).-*(~^v^)~");
        Console.WriteLine("");
        
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre + " | " + cliente.Telefono);
        }

        Console.ReadLine();
    }

    public void ListarVendedores()
    {
        Console.Clear();
        Console.WriteLine("~(^v^~)*-.(^v^).-*(~^v^)~");
        Console.WriteLine("= Lista de Vendedores =");
        Console.WriteLine("~(^v^~)*-.(^v^).-*(~^v^)~");
        Console.WriteLine("");
        
        foreach (var vendedor in ListadeVendedores)
        {
            Console.WriteLine(vendedor.Codigo + " | " + vendedor.Nombre + " | " + vendedor.CodigoVendedor);
        }

        Console.ReadLine();
    }

    public void CrearOrden()
    {
        Console.WriteLine("~(^v^~)*-.(^v^).-*(~^v^)~");
        Console.WriteLine("= Creando Orden =");
        Console.WriteLine("~(^v^~)*-.(^v^).-*(~^v^)~");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el codigo del cliente: ");
        string codigoCliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);        
        if (cliente == null)
        {
            Console.WriteLine("Este Cliente no existe en el registro");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el codigo del vendedor: ");
        string codigoVendedor = Console.ReadLine();

        Vendedor vendedor = ListadeVendedores.Find(v => v.Codigo.ToString() == codigoVendedor);
        if (vendedor == null) 
        {
            Console.WriteLine("Vendedor no existe");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Vendedor: " + vendedor.Nombre);
            Console.WriteLine("");
        }

        int nuevoCodigo = ListaOrdenes.Count + 1;

        Orden nuevaOrden = new Orden(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente, vendedor);
        ListaOrdenes.Add(nuevaOrden);

        while(true)
        {
            Console.WriteLine("Ingrese el producto: ");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);        
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                nuevaOrden.AgregarProducto(producto);
            }

            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }

        Console.WriteLine("SubTotal de la orden es de: " + nuevaOrden.SubTotal);

        Console.WriteLine("Impuesto de la orden es de: " + nuevaOrden.Impuesto);

        Console.WriteLine("Total de la orden es de: " + nuevaOrden.Total);
        Console.ReadLine();
    }

    public void ListarOrdenes()
    {
        Console.Clear();
        Console.WriteLine("~(^v^~)*-.(^v^).-*(~^v^)~");
        Console.WriteLine("= Lista de Ordenes =");
        Console.WriteLine("~(^v^~)*-.(^v^).-*(~^v^)~");
        Console.WriteLine("");  
        Console.WriteLine("~(^v^~)*-.(^v^).-*(~^v^)~ ~(^v^~)*-.(^v^).-*(~^v^)~");
        Console.WriteLine("= Codigo | Fecha | SubTotal | Impuesto | Total =");
        Console.WriteLine("=              Cliente | Vendedor              =");
        Console.WriteLine("~(^v^~)*-.(^v^).-*(~^v^)~ ~(^v^~)*-.(^v^).-*(~^v^)~");
        Console.WriteLine("");  

        foreach (var orden in ListaOrdenes)
        {
            Console.WriteLine(orden.Codigo + " | " + orden.Fecha + " | " + orden.SubTotal + " | " + orden.Impuesto + " | " + orden.Total);
            Console.WriteLine(orden.Cliente.Nombre + " | " + orden.Vendedor.Nombre);
            
            foreach (var detalle in orden.ListaOrdenDetalle)
            {
                Console.WriteLine("     " + detalle.Producto.Descripcion + " | " + detalle.Cantidad + " | " + detalle.Precio);
            }

            Console.WriteLine();
        } 

        Console.ReadLine();
    }
}