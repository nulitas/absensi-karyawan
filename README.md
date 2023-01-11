<h2 style="font-weight: 700; font-size: 2rem">Sistem Absensi Karyawan</h2>

<br>
Project UAS Visual Basic Semester 3

+ Harits Taqiy Wibowo (2107411034)
+ Andra Rizki Pratama (2107411043)
+ Muhammad Asaduddin (2107411046)
+ Putra Ravelyon (2107411050)

<hr>
<h2 style="font-weight: 700">Requirement</h2>
<hr>

### Class :
- KaryawanClass
- JabatanClass
- AbsensiClass
- PenggajianClass

### Form :
- Sign In dan Sign Up 
- Form Karyawan (Berisi Data Karyawan)
- Form Jabatan (Berisi Jabatan apa yang ada di perusahaan dan gaji perhari)
- Form Absen (Berisi Absensi Masuk dan Absensi Keluar Karyawan)
- Tambah, Hapus, dan Ubah Karyawan & Jabatan
- Hitung, Hapus, dan Ubah Penggajian
- Absensi Masuk & Absensi Keluar

### Fitur :

- Sign In, Sign Out, dan Sign Up
- Form Karyawan Berisi Data Karyawan
- Form Jabatan Berisi Jabatan apa yang ada di perusahaan dan gaji perhari
- Form Absen Berisi Absensi Masuk dan Absensi Keluar Karyawan
- Standard dalam 1 hari adalah 8 jam kerja
- Jam Masuk 9, Jam Pulang 17:00
- Kalau telat dari jam Masuk gaji dikurang 2% dari gaji perhari
- Form Penggajian Menghitung jumlah gaji perbulan (gaji bisa dihitung walaupun hanya masuk 1 hari)

### Table :

- User (id, user, email, password)
- Karyawan (id_karyawan, nik, nama, alamat, id_jabatan, foto)
- Absensi (id_absensi, id_karyawan, tanggal, waktu_absen_masuk, waktu_absen_keluar)
- Jabatan (id_jabatan, nama_jabatan, gaji_perhari)
- Penggajian (id_karyawan, bulan_ke, total_gaji)

<br>

