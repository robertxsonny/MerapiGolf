using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerapiGolfLogistik.Classes
{
    public class InsertData
    {
        private MerapiGolfLogistikEntities dbContent;
        public async Task<Barang> InsertItem(Guid catid, string itemname, string subsi, string pcs, DateTime inputdate)
        {
            using(dbContent = new MerapiGolfLogistikEntities())
            {
                Barang barang = new Barang();
                barang.id_kategori = catid;
                barang.nama_barang = itemname;
                barang.satuan = pcs;
                barang.subsi = subsi;
                barang.id = Guid.NewGuid();
                //barang.tanggalinput = inputdate;
                dbContent.mg_barang.Add(barang);
                await dbContent.SaveChangesAsync();
                return barang;
            }
        }

        public async Task<Supplier> InsertSupplier(Guid supplierId, 
            string name, string address, string phone, string email)
        {
            using(dbContent = new MerapiGolfLogistikEntities())
            {
                Supplier supplier = new Supplier();
                supplier.id = supplierId;
                supplier.nama_supplier = name;
                supplier.telepon_supplier = phone;
                supplier.email_supplier = email;
                dbContent.mg_supplier.Add(supplier);
                await dbContent.SaveChangesAsync();
                return supplier;
            }
        }

        public async Task<Boolean> UpdateSupplier(Guid supplierId,
            string name, string address, string phone, string email)
        {
            using (dbContent = new MerapiGolfLogistikEntities())
            {
                var suppliers = dbContent.mg_supplier.Where(p => p.id == supplierId).ToList();
                if (suppliers.Count != 0)
                {
                    var supplier = suppliers.Single();
                    supplier.id = supplierId;
                    supplier.nama_supplier = name;
                    supplier.telepon_supplier = phone;
                    supplier.email_supplier = email;
                    await dbContent.SaveChangesAsync();
                    return true;
                }
                else return false;
            }
        }
    }
}
