# AbsensiKaryawanApp

Class:
Users
Karyawan
Absensi
Jabatan
Penggajian

Form :
Sign In
Sign Up
Form Karyawan (Data Grid View Karyawan)
Tambah Karyawan
Hapus Karyawan
Edit Karyawan
Form Jabatan  (Data Grid View Jenis Jabatan)
Tambah Jabatan
Hapus Jabatan
Edit Jabatan
Form Absensi (Data Grid View Absensi)
Absensi Masuk
Absensi Keluar
Ganti Status Absensi
Hapus Absensi
Form Penggajian (Data Grid View Penyewa)
Hitung Penggajian
Ubah Penggajian
Hapus Penggajian


Fitur :
Sign In, Sign Out, dan Sign Up Pemilik
Form Karyawan Berisi Data Karyawan
Form Jabatan Berisi Jabatan apa yang ada di perusahaan dan gaji perhari
Form Absen Berisi Absensi Masuk dan Absensi Keluar Karyawan
Standard dalam 1 hari adalah 8 jam kerja
Jam Masuk 9, Jam Pulang 17:00
Kalau telat dari jam Masuk gaji dikurang 2% dari gaji perhari
Form Penggajian Menghitung jumlah gaji perbulan (gaji bisa dihitung walaupun hanya masuk 1 hari)
 
Table :
User (id, user, email, password, foto)
Karyawan (id_karyawan, nik, nama, alamat, id_jabatan)
Absensi (id_absensi, id_karyawan, tanggal, waktu_absen_masuk, waktu_absen_keluar)
Jabatan (id_jabatan, nama_jabatan, gaji_perhari)
Penggajian (id_karyawan, bulan_ke, total_gaji)
