<template>
  <div class="">
            <div class="detail-form-content-center-title">
              {{ emailItem.name }}
            </div>
            <div class="">
              {{ emailItem.description }}
            </div>
            <div class="">
            <input
              type="text"
              width="100%"
              class=""
            />
          </div>
          </div>
</template>
<script>
import { v4 as uuidv4 } from "uuid";

export default {
  components: {},
  props: {
    item: Object,
    groupIndex: Number,
  },
  data() {
    return {
      form: [],
      emailItem: this.item,
      activeGroupIndex: null,
    };
  },
  mounted() {
    if (this.item.is_create == true) {
      this.emailItem = this.item;
      // this.emailItem.is_create=false;
      this.loadFromLocalStorage();
    } else {
      this.loadFromLocalStorage();
      this.findItem();
    }
  },
  methods: {
    goBack() {
      this.$router.go(-1);
    },
    create() {
      debugger;
      this.emailItem.is_create = false;
      this.form.phases[this.groupIndex].items.push(this.emailItem);
    },
    update() {
      const a = this.form.phases.filter((row) => {
        return row;
      });
      debugger

      const b = this.item.id;
      const c= a[this.groupIndex];
      a[this.groupIndex].items.forEach((element) => {
        if (element.id == b) {
          console.log(element);
          element = this.emailItem;
        }
      });
    },
    save() {
      if (this.emailItem.is_create == true) {
        this.create();
      } else {
        this.update();
      }
      localStorage.setItem("myObject", JSON.stringify(this.form));
      this.goBack();
    },
    loadFromLocalStorage() {
      const savedObject = localStorage.getItem("myObject");
      if (savedObject) {
        this.form =JSON.parse(savedObject);
      }
    },
    findItem() {
      const a = this.form.phases.filter((row) => {
        return row;
      });
      const b = this.item.id;
      for (var i = 0; i < a.length; i++) {
        a[i].items.forEach((element) => {
          if (element.id == b) {
            console.log(element);
            this.emailItem = element;
          }
        });
      }
    },
  },
};
</script>
<style scoped>
@import "../../../assets/css/item-style/item-style.css";
</style>
