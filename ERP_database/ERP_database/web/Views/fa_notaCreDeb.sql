CREATE VIEW web.fa_notaCreDeb
AS
SELECT        fa_notaCreDeb.IdEmpresa, fa_notaCreDeb.IdSucursal, fa_notaCreDeb.IdBodega, fa_notaCreDeb.IdNota, fa_notaCreDeb.CreDeb, fa_notaCreDeb.NumNota_Impresa, fa_notaCreDeb.no_fecha, fa_cliente_contactos.Nombres, 
                         SUM(fa_notaCreDeb_det.sc_subtotal) AS sc_subtotal, SUM(fa_notaCreDeb_det.sc_iva) AS sc_iva, SUM(fa_notaCreDeb_det.sc_total) AS sc_total, fa_notaCreDeb.Estado
FROM            fa_notaCreDeb INNER JOIN
                         fa_cliente_contactos ON fa_notaCreDeb.IdEmpresa = fa_cliente_contactos.IdEmpresa AND fa_notaCreDeb.IdCliente = fa_cliente_contactos.IdCliente AND 
                         fa_notaCreDeb.IdContacto = fa_cliente_contactos.IdContacto LEFT OUTER JOIN
                         fa_notaCreDeb_det ON fa_notaCreDeb.IdEmpresa = fa_notaCreDeb_det.IdEmpresa AND fa_notaCreDeb.IdSucursal = fa_notaCreDeb_det.IdSucursal AND fa_notaCreDeb.IdBodega = fa_notaCreDeb_det.IdBodega AND 
                         fa_notaCreDeb.IdNota = fa_notaCreDeb_det.IdNota
GROUP BY fa_notaCreDeb.IdEmpresa, fa_notaCreDeb.IdSucursal, fa_notaCreDeb.IdBodega, fa_notaCreDeb.IdNota, fa_notaCreDeb.CreDeb, fa_notaCreDeb.NumNota_Impresa, fa_notaCreDeb.no_fecha, fa_cliente_contactos.Nombres, 
                         fa_notaCreDeb.Estado