namespace PigeonReviewProject.Interfaces
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetAllOwner();
        Owner GetOwner(int  ownerId);
        ICollection<Owner> GetOwnerOfAPigeon(int pigeonId);

        ICollection<Pigeon > GetPigeonOfAOwner(int ownerId);
        bool OwnerExists(int ownerId);

    }
}
