SELECT kategori.id AS idkategori, kategori.nama_kategori, dbo.mg_barang.id, dbo.mg_stok_barang_total.nama_barang, SUM(dbo.mg_pembelian_item.banyak_barang)-SUM(pengambilan.countambil) AS stoksaldo, SUM(dbo.mg_pembelian_item.banyak_barang) AS stokmasuk, SUM(pengambilan.countambil) 
             AS stokkeluar, SUM(dbo.mg_pembelian_item.banyak_barang * dbo.mg_pembelian_item.harga_satuan) AS jumlahhrgbeli, SUM(pengambilan.countambil * dbo.mg_pembelian_item.harga_satuan) AS jumlahhrgpakai, 
             SUM(dbo.mg_pembelian_item.banyak_barang * dbo.mg_pembelian_item.harga_satuan) - SUM(pengambilan.countambil * dbo.mg_pembelian_item.harga_satuan) AS saldo, dbo.mg_barang.satuan
FROM   dbo.mg_stok_barang_total INNER JOIN
             dbo.mg_pembelian_item ON dbo.mg_stok_barang_total.id_barang = dbo.mg_pembelian_item.barang_id INNER JOIN
             dbo.mg_barang ON dbo.mg_pembelian_item.barang_id = dbo.mg_barang.id LEFT OUTER JOIN
                 (SELECT pengambilanitem.tanggal_masuk, SUM(pembelianitem.banyak_barang) AS banyak_barang, SUM(pengambilanitem.banyak_barang) AS countambil, pengambilanitem.id_pembelian_barang
                 FROM    dbo.mg_total_pengambilan AS pengambilanitem LEFT OUTER JOIN
                              dbo.mg_pembelian_item AS pembelianitem ON pembelianitem.id = pengambilanitem.id_pembelian_barang
                 GROUP BY pengambilanitem.tanggal_masuk, pengambilanitem.id_pembelian_barang) AS pengambilan ON dbo.mg_pembelian_item.id = pengambilan.id_pembelian_barang INNER JOIN
             dbo.mg_pembelian ON dbo.mg_pembelian_item.no_nota = dbo.mg_pembelian.id LEFT OUTER JOIN
             dbo.mg_kategori AS kategori ON kategori.id = dbo.mg_barang.id_kategori
			 WHERE pengambilan.tanggal_masuk >= '2016-01-12' AND
			 pengambilan.tanggal_masuk <= '2016-01-15' AND
			 dbo.mg_pembelian.tanggal >= '2016-01-12' AND
			 dbo.mg_pembelian.tanggal <= '2016-01-15'
GROUP BY kategori.id, kategori.nama_kategori, dbo.mg_barang.id, dbo.mg_stok_barang_total.nama_barang, dbo.mg_barang.satuan