import { Button } from "@/components/ui/button"
import { Play, Info } from "lucide-react"

export default function MainMovie() {
  return (
    <div className="bg-maverick p-20 h-[600px] bg-cover bg-center rounded-md">
      <div className="flex flex-col justify-end pt-52">
        <p className="text-white text-8xl font-bold tracking-tight">TopGun</p>
        <p className="text-white text-5xl mt-3 font-light tracking-tight ml-3">MAVERICK</p>
        <div className="flex flex-start items-center gap-4 mt-5">
          <Button size="xl" variant="secondary">
            <Play className="mr-2 h-6 w-6" /> Odtwórz
          </Button>
          <Button size="xl">
            <Info  className="mr-2 h-6 w-6" /> Więcej informacji
          </Button>
        </div>

      </div>

    </div>
  )
}