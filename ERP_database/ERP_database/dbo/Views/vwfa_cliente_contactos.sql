CREATE VIEW vwfa_cliente_contactos
AS
SELECT fa_cliente_contactos.IdEmpresa, fa_cliente_contactos.IdCliente, fa_cliente_contactos.IdContacto, fa_cliente_contactos.Nombres, fa_cliente_contactos.Telefono, fa_cliente_contactos.Celular, fa_cliente_contactos.Correo, 
                  fa_cliente_contactos.Direccion, fa_cliente_contactos.IdCiudad, fa_cliente_contactos.IdParroquia, tb_parroquia.nom_parroquia
FROM     fa_cliente_contactos LEFT OUTER JOIN
                  tb_parroquia ON fa_cliente_contactos.IdParroquia = tb_parroquia.IdParroquia