import PageHeader from "@/components/PageHeader";
import MainMovie from "@/components/MainMovie";

export default function Home() {
  return (
    <div className="h-full bg-black">
      <div className="container">
        <PageHeader/>
        <MainMovie/>
      </div>

    </div>
  )
}
