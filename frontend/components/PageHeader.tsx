import Image from "next/image";

export default function PageHeader() {
  return (
    <div className="flex items-center justify-between py-5">
      <div className="flex items-center justify-start gap-6">
        <Image
          src="/netflix-logo.png"
          alt="Netflix Logo"
          width={125}
          height={100}/>
        <div className="flex text-white gap-4">
          <p>Strona główna</p>
          <p>Komedie</p>
          <p>Dramaty</p>
          <p>Horrory</p>
        </div>
      </div>
      <p className="text-white">Logowanie</p>
    </div>
  )
}